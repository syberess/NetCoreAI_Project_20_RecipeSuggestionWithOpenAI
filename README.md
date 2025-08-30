# 🍲 NetCoreAI Project 20 - Recipe Suggestion with OpenAI

Bu proje, **ASP.NET Core MVC** ile geliştirilmiş bir yapay zeka destekli yemek tarifi öneri uygulamasıdır.  
Kullanıcı elindeki malzemeleri girdikten sonra, **OpenAI Chat Completions API** çağrılır ve uygun yemek tarifi önerileri oluşturulur.  

---

## 🛠️ Kullanılan Teknolojiler
- ASP.NET Core MVC (Model-View-Controller)  
- OpenAI API (Chat Completions - `gpt-3.5-turbo`)  
- HttpClient (API çağrısı için)  
- System.Text.Json (JSON işleme)  
- Bootstrap (ön yüz tasarımı)  

---

## 📂 Proje Yapısı
- **Controllers/**
  - `DefaultController.cs` → Kullanıcıdan malzeme listesi alır, OpenAiService üzerinden tarif oluşturur:contentReference[oaicite:2]{index=2}  
  - `HomeController.cs` → Anasayfa ve hata yönetimi:contentReference[oaicite:3]{index=3}  
- **Models/**
  - `OpenAiService.cs` → OpenAI API ile bağlantıyı sağlar, tarifleri döndürür:contentReference[oaicite:4]{index=4}  
  - `ErrorViewModel.cs` → MVC hata modeli:contentReference[oaicite:5]{index=5}  
- **Views/**
  - `CreateRecipe.cshtml` → Kullanıcının malzeme girdiği form ve tarif çıktısı  
  - `_Layout.cshtml` → Ana tasarım şablonu  
  - `Index.cshtml`, `Privacy.cshtml` vb. sayfalar  
- **wwwroot/**
  - `css/_Layout.cshtml.css` → Stil düzenlemeleri:contentReference[oaicite:6]{index=6}  

---

## ⚙️ Kurulum ve Çalıştırma
1. Repo’yu klonla:
   git clone https://github.com/kullaniciadiniz/NetCoreAI_Project_20_RecipeSuggestionWithOpenAI.git
   cd NetCoreAI_Project_20_RecipeSuggestionWithOpenAI
Models/OpenAiService.cs dosyasında kendi OpenAI API anahtarını ekle:
private const string apiKey = "YOUR_API_KEY";
Bağımlılıkları yükle ve çalıştır:
dotnet restore
dotnet run
Tarayıcıda aç:
https://localhost:5001/Default/CreateRecipe
Malzemeleri gir → Önerilen tarif ekranda görünecek ✅

✨ Özellikler
✔️ Kullanıcı malzemelerini girerek tarif önerisi alabilir

✔️ OpenAI API ile doğal dil tabanlı tarif oluşturma

✔️ MVC yapısında profesyonel proje mimarisi

✔️ Bootstrap tabanlı basit ve şık arayüz

﻿
