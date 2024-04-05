using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Addresses
        Address lectureAddress = new Address("398 Zoo Boulevard", "Chicago", "Nebraska", "USA");
        Address receptionAddress = new Address("1205 Corral Way", "Springfield", "Georgia", "USA");
        Address outdoorGatheringAddress = new Address("Myslim Shyri", "Tirana", "Tirane", "Albania");

        //Lecture
        Lecture lecture = new Lecture("Monkey Speech", "Come listen to this orangutan who learned how to talk!", "21 March 2024", "12:00pm", lectureAddress, "Orange the Orangutan", 12000);
        Console.WriteLine("\nLecture Ads:\n");
        Console.WriteLine("Short Details: " + lecture.ShortDetails() + "\n");
        Console.WriteLine("Standard Details: " + lecture.StandardDetails() + "\n");
        Console.WriteLine("Full Details: " + lecture.FullDetails() + "\n");

         //Reception
        Reception reception = new Reception("Pisarski Wedding Reception", "Celebrate the marriage of Alex and Alexis Pisarski!", "25 December 2024", "5:00pm", receptionAddress, "p1sarsk1@gmail.com");
        Console.WriteLine("\nReception Ads:\n");
        Console.WriteLine("Short Details: " + reception.ShortDetails() + "\n");
        Console.WriteLine("Standard Details: " + reception.StandardDetails() + "\n");
        Console.WriteLine("Full Details: " + reception.FullDetails() + "\n");

         //Lecture
        OutdoorGathering outdoorGathering = new OutdoorGathering("Ultimate Frisbee", "Come enjoy some frisbee with the elders and sisters of the LDS Church!", "29 March 2018", "6:00am", outdoorGatheringAddress, "Sunny and Clear");
        Console.WriteLine("\nOutdoor Gathering Ads:\n");
        Console.WriteLine("Short Details: " + outdoorGathering.ShortDetails() + "\n");
        Console.WriteLine("Standard Details: " + outdoorGathering.StandardDetails() + "\n");
        Console.WriteLine("Full Details: " + outdoorGathering.FullDetails() + "\n");


    }
}