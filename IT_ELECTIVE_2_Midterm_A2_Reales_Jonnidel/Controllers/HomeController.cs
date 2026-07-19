using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_Midterm_A2_Reales_Jonnidel.Models;

namespace IT_ELECTIVE_2_Midterm_A2_Reales_Jonnidel.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Greeting"] = "Hello, I'm";
        ViewData["Name"] = "Jonnidel";
        ViewData["LastNameGradient"] = "Reales";
        ViewData["JobTitle"] = "IT Student | Aspiring Game & Web Developer";
        ViewData["Intro"] = "Hi, I'm Jonnidel Reales, a BSIT student with a passion for programming and technology. I enjoy creating projects, exploring game development, and continuously improving my skills in software development. I'm eager to learn new things and gain experience that will help me grow as a future IT professional.";
        return View();
    }

    public IActionResult About()
    {
        ViewData["BioTitle"] = "Who I Am";
        ViewData["BioParagraph1"] = "I am Jonnidel Reales, a Bachelor of Science in Information Technology (BSIT) student at Lyceum of Alabang with a strong interest in software development, game development, and web development. I graduated from Colegio De San Pedro under the STEM strand, where I developed analytical and problem-solving skills through science and mathematics. My decision to pursue Information Technology was inspired by my love for gaming and my curiosity about how games are created. This curiosity motivated me to learn programming and explore the technologies behind software and game development.";
        ViewData["BioParagraph2"] = "Beyond academics, I enjoy programming, game development, and gaming, which continue to motivate me to improve my technical skills. I am interested in learning how applications and games are built from writing code and implementing game mechanics to creating engaging user experiences. Through personal projects and continuous self-learning, I strive to expand my knowledge and prepare for a successful career as a software developer. My goal is to build meaningful software and interactive experiences while continuously growing as an IT professional.";
        ViewData["CareerGoals"] = "To become a skilled game developer or web developer, creating interactive experiences and applications that people enjoy. I aim to secure an internship or entry-level position where I can apply my programming knowledge, contribute to real projects, and continuously grow as a developer in the tech industry.";
        return View();
    }

    public IActionResult Skills()
    {
        ViewData["SectionTitle"] = "My Skills";
        return View();
    }

    public IActionResult Projects()
    {
        ViewData["Proj1Title"] = "Library Management System";
        ViewData["Proj1Desc"] = "A console-based application that allows users to manage a collection of books in a library. Features include adding new books, searching by title or author, borrowing and returning books, and displaying all available books with their current status.";
        
        ViewData["Proj2Title"] = "Parking Management System";
        ViewData["Proj2Desc"] = "A console-based parking lot management system that tracks vehicle entries and exits, calculates parking fees based on duration, manages available parking slots, and generates summary reports of daily parking activity.";
        
        ViewData["Proj3Title"] = "Periodic Table Finder";
        ViewData["Proj3Desc"] = "A console-based application that allows users to look up chemical elements from the periodic table. Users can search by element name, symbol, or atomic number to view detailed information such as atomic mass, category, and electron configuration.";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Email"] = "realesjonnidel@gmail.com";
        ViewData["Mobile"] = "+63 960 375 8429";
        ViewData["GitHub"] = "github.com/WspJon";
        ViewData["GitHubUrl"] = "https://github.com/WspJon";
        ViewData["Facebook"] = "facebook.com/Realessst";
        ViewData["FacebookUrl"] = "https://www.facebook.com/Realessst";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
