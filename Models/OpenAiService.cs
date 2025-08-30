using System.Text;
using System.Text.Json;

namespace NetCoreAI_Project_20_RecipeSuggestionWithOpenAI.Models
{
    public class OpenAiService
    {
        private readonly HttpClient _httpClient;
        private const string OpenAiUrl = "https://api.openai.com/v1/chat/completions";
        private const string apiKey = "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";
    

        public OpenAiService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        }

        public async Task<string> GetRecipeAsync(string ingredients)
        {
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new {role="system", content="Sen profesyonel bir aşçısın. Kullanıcının elindeki malzemelere göre yemek tarifi öner."},
                    new {role="user", content=$"Elimde şu malzemeler var : {ingredients}.Ne yapabilirim?"}
                },
                temperature= 0.7 //bu değer openai nin verdiği cevabın rastgeleliğini (tahmin gücünü) belirler düşük olunca daha karaklı yükselince daha çılgın  fikirler vermesini sağlar
            };

            var jsonRequest = JsonSerializer.Serialize(requestBody);
            var response = await _httpClient.PostAsync(OpenAiUrl, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));
            var responseBody = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(responseBody);
            return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();


        }
    
    }
}
