# 🌐 Portfolio Project – .NET Developer Portfolio

🔗 **Live Website**: [https://portfolio-webapp-nasi-ddb3gacuc0bqd5ek.swedencentral-01.azurewebsites.net](https://portfolio-webapp-nasi-ddb3gacuc0bqd5ek.swedencentral-01.azurewebsites.net)

## 📌 Introduktion

Detta är mitt personliga **utvecklarportföljprojekt**, skapat självständigt som en del av kursen *Projekt 2* under .NET-utbildningen. Syftet med projektet är att presentera mina tidigare utvecklingsarbeten på ett modernt, interaktivt och professionellt sätt – samt att öva på fullstack-utveckling, API-integrationer och molnpublicering.

---

## 🧩 Funktioner

- ✅ En responsiv portföljsida byggd med Razor Pages
- ✅ Integration av ett externt väder-API (temperatur och plats)
- ✅ Projektlista hämtad från en egenutvecklad RESTful Web API
- ✅ Kontaktformulär för att spara meddelanden i databas
- ✅ Azure Hosting för både API och WebApp

---

## 🛠️ Använda teknologier

| Lager | Teknologier |
|-------|-------------|
| **Frontend** | Razor Pages (.NET 9), HTML5, CSS3, Bootstrap |
| **Backend** | ASP.NET Core Web API, C# |
| **Databas** | SQL Server, Entity Framework Core |
| **Testing** | NUnit (för API-metoder) |
| **Versionering** | Git, GitHub |
| **Deployment** | Microsoft Azure (App Service, SQL Database) |
| **Övrigt** | OpenMeteo API (väder), REST-arkitektur |

---

## 🔗 API-Beskrivning

API:t är en del av lösningen och används för att presentera mina projekt på webbsidan.

### 📂 Endpoints

| Metod    | URL                      | Funktion                         |
|----------|--------------------------|----------------------------------|
| `GET`    | `/api/projects`          | Hämta alla projekt               |
| `GET`    | `/api/projects/{id}`     | Hämta specifikt projekt via ID   |
| `POST`   | `/api/projects`          | Skapa ett nytt projekt           |
| `PUT`    | `/api/projects/{id}`     | Uppdatera ett befintligt projekt|
| `DELETE` | `/api/projects/{id}`     | Radera ett projekt               |

### 📦 Databasstruktur

#### `Project`-entiteten

