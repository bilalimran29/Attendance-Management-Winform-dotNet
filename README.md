# 📘 Attendance Management System (AMSF)

A simple yet powerful **Attendance Management System** built with **C# WinForms** and **Microsoft SQL Server**. This system allows easy management of teachers and students, along with marking and viewing attendance.

---

## 🚀 Features

- 👤 **Teacher Registration** (Add, Update, Delete, View)
- 🧑‍🎓 Student Registration *(extendable)*
- 🗓️ Attendance Marking *(extendable)*
- 📊 DataGridView integration for viewing records
- 🗃️ Uses Stored Procedures and Secure SQL Parameters
- ✅ Clean, professional WinForms UI

---

## 🏗️ Technologies Used

- C# WinForms (.NET Framework)
- SQL Server 2019+
- Visual Studio 2022
- Stored Procedures, Triggers, and JOINs

---

## 📁 Project Structure

```
AMSF/
│
├── Database/
│   ├── Scripts.sql              # SQL Table + Stored Procedures
│
├── Forms/
│   ├── TeacherForm.cs          # C# Code for Teacher Form
│   ├── TeacherForm.Designer.cs# Auto-generated UI code
│   └── LoginForm.cs            # (Extendable)
│
├── Database.cs                 # Centralized DB connection and execution
├── AMSF.csproj                 # Project file
└── README.md
```

---

## 🛠️ Setup Instructions

### ✅ Prerequisites

- [ ] Visual Studio 2022 or later
- [ ] SQL Server (Express or Developer Edition)
- [ ] SQL Server Management Studio (SSMS)

### 🔧 1. Clone the Repository
```bash
git clone https://github.com/your-username/amsf.git
cd amsf
```

### 🧱 2. Setup the SQL Database

1. Open `Scripts.sql` in **SSMS**
2. Run the script to create:
   - `Teachers` table
   - Stored procedures:
     - `sp_AddTeacher`
     - `sp_UpdateTeacher`
     - `sp_DeleteTeacher`

### 🎨 3. Open Project in Visual Studio

1. Launch Visual Studio
2. Open `AMSF.sln`
3. Rebuild the solution

### 🔌 4. Update DB Connection (if needed)

Open `Database.cs` and update your SQL Server connection string:
```csharp
private SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=amsf_db;Integrated Security=True");
```

---

## ✨ Usage

1. Run the app
2. Navigate to the **Teacher Form**
3. Add, Update, or Delete teachers
4. Select rows from the grid to edit
5. Click “Clear” to reset form

---

## 📸 Screenshots

> (Add screenshots here if desired for UI preview)

---

## 💡 Future Improvements

- Student Registration and Login
- Attendance Marking and Reports
- Admin Dashboard
- Authentication
- Export to Excel/PDF

---

## 🤝 Contribution

Pull requests and suggestions are welcome. Feel free to fork and improve the project!

---

## 📄 License

MIT License

---

## 👨‍💻 Developed By

- [Your Name](https://github.com/your-username)