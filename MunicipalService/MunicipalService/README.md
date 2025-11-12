# Municipal Service Application – Part 2  
**Programming 3B – Municipal Services App for South Africa (Collaboration)**  
**Developer:** Tebogo Sepadi Thobejane  
**Date:** October 2025  

---

## 📘 Overview
The Municipal Service Application provides South African citizens with a single platform to:
- Report local municipal issues.  
- View local events and announcements.  
- Check the status of submitted service requests.  

This project continues from **Part 1**, adding advanced data-structure features (stacks, queues, priority queues, dictionaries, sets) and a recommendation engine for event searches.

---

## ⚙️ Project Structure
| Folder | Purpose |
|:-------|:---------|
| **Data** | Contains `FakeDatabase.cs` (in-memory data), `PriorityQueue.cs` for priority ordering. |
| **Models** | Data models for `Event`, `Issue`, etc. |
| **Forms** | All Windows Forms: `MainForm`, `ReportIssueForm`, `EventsForm`, `StatusForm`. |
| **Program.cs** | Application entry point. |

---

## 🧩 Implemented Features – Part 2
### Main Menu
- Navigation buttons for: **Report Issue**, **Local Events & Announcements**, and **Service Request Status**.  

### Local Events & Announcements Page
- Displays all upcoming events.  
- **Search by Category or Date** (validated `dd/MM/yyyy`).  
- **SortedDictionary** – orders events by date.  
- **HashSet** – stores unique event categories.  
- **Stack / Queue / Priority Queue** – used to manage recent searches and upcoming event priority.  
- **Dictionary** – O(1) lookup of events by ID.  
- **Recommendation Feature** – suggests related events based on user search history.  

### Data Structures Summary
| Data Structure | Usage |
|:---------------|:------|
| **Stack / Queue** | Track recent user searches and upcoming events. |
| **Priority Queue** | Sorts soonest events to highest priority. |
| **SortedDictionary** | Organises events chronologically. |
| **Dictionary** | Fast lookup of events by ID. |
| **HashSet / Set** | Maintains unique event categories. |

---

## 🚀 How to Compile and Run
### Option 1 – Using Visual Studio
1. Open **Visual Studio 2022 (or later)**.  
2. Select **File → Open → Project/Solution**.  
3. Browse to the folder containing this project and open the `.sln` file.  
4. Press **F5 (Run)** or click **Start ▶️**.  
5. The **Main Menu Form** will appear with navigation options.

### Option 2 – Manual Run
1. Navigate to the project folder in Windows File Explorer.  
2. Open `bin → Debug → MunicipalServiceApplication.exe`.  
3. Double-click the `.exe` to launch the app.

---

## 💡 User Instructions
1. **Report Issue:** Opens the form to capture issue details (from Part 1).  
2. **Local Events & Announcements:**  
   - View, search, and filter events by category or date.  
   - See automatic recommendations based on your searches.  
3. **Service Request Status:** Track progress of submitted reports.  

---

## 🧠 Technical Details
- **Language:** C# (.NET Framework 4.8 / WinForms).  
- **IDE:** Visual Studio 2022.  
- **Core Files:** `FakeDatabase.cs`, `PriorityQueue.cs`, `EventsForm.cs`, `MainForm.cs`.  
- **Data Storage:** In-memory collections (no external database).  

---

## 🧾 Attribution / References
- Microsoft Docs (2025). *Windows Forms Overview*. Available at: https://learn.microsoft.com/dotnet/desktop/winforms/  
- GeeksforGeeks, 2025. SortedDictionary Implementation in C#. Available at: https://www.geeksforgeeks.org/c-sharp/sorteddictionary-implementation-in-c-sharp/
- Code Maze, 2024. Priority Queue in C# tutorial. Available at: https://code-maze.com/csharp-priority-queue/
- GeeksforGeeks, 2025. Dictionary vs Hashtable in C#. Available at: https://www.geeksforgeeks.org/difference-between-hashtable-and-dictionary-in-c-sharp/
- C#Corner, “How to add items to a SortedDictionary with C#” by Neel Beniwal. Available at: https://www.c-sharpcorner.com/UploadFile/dbeniwal321/how-to-add-items-to-a-sorted-dictionary-with-C-Sharp/
---

## 📁 Submission Notes
Ensure the following files are included when submitting:
1. **Source Code (.cs)** files.  
2. **Forms and Designer** files.  
3. **README.md** (this file).  
4. Optional screenshots for verification.

---

**End of README**
