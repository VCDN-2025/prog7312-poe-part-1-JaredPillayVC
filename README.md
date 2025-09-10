# Municipality Services Application

This application is a **Windows Forms Application** that uses C# .NET 9.0. It allows users to log and track municipal service issues in a professional, user-friendly way.

The application was designed with a clean UI, proper validation, and custom-built data structures.

## 🎥 Demo Video
A video demonstration of the application running will be provided here: 
**YouTube Link:** _to be added_

In the video I demonstrate: 
- Opening the dashboard
- Navigating with the sidebar
- Submitting a new issue with validation 
- Adding attachments
- Viewing the saved issue in the _data_ folder

## ✅ Features
- **Professional UI**
  - A dashboard with sidebar navigation and modern icons  
  - A report form with responsive layout  
  - Consistent fonts and theme inspired by eThekwini Municipality  

- **Custom Data Structions** 
    - A `ForwardList<T>` (singly linked list) to store issues and attachments
    - This replaces built-in generic collections like `List<>` and arrays

- **Validation Rules**
    - **Location:** Required, minimum of 5 characters. The location is validated against the OpenStreetMap Nominatim service.
    - **Category:** Required (selected from dropdown).
    - **Description:** Required, minimum of 5 words.
    - **Attachments:** Required, at least one attachment. Allowed types are `.jpg`, `.jpeg`, `.png`, `.heic`, or `.pdf`, and each file must be ≤ 10 MB.

- **Progress Feedback:**  
  - A progress bar updates as fields are validated, so users know when the form is complete.  


- **Storage:**  
  - Issues are saved to text files in a `Data` folder (with unique ticket IDs).  
  - Attachments are copied into a dedicated folder with unique filenames.  

## 🚀 How to Run the Application

### Prerequisites
- .NET 9 SDK
- Windows OS (WinForms only runs on Windows)
- Visual Studio 2022 (recommended) or Visual Studio Code

### Steps
1. Clone the repo:
   ```bash
   git clone https://github.com/VCDN-2025/prog7312-poe-part-1-JaredPillayVC.git
   cd prog7312-poe-part-1-JaredPillayVC
2. Open the solution in Visual Studio 2022.
3. Set the startup project to MunicipalityServicesApplication.App.
4. Run the application (F5).

Note: When running, the application will automatically create a Data folder where all logged issues and attachment issues are stored. 

## 📄 Example of Saved Issue File
TicketId: MAPP-20250909-XYZ123

CreatedUtc: 2025-09-09T13:00:00Z

Category: Water

Location: 123 Main Street, Durban

Description: [Full description entered by user...]

Attachments: 2
 - Data/attachments/abcd1234_leak.jpg
 - Data/attachments/efgh5678_notes.pdf