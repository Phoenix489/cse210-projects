using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<Reference> references = new List<Reference>
        {
            // Add Bible scriptures
            new Reference("Bible", "Matthew", "5", "14-16", "You are the light of the world. A town built on a hill cannot be hidden. Neither do people light a lamp and put it under a bowl. Instead they put it on its stand, and it gives light to everyone in the house. In the same way, let your light shine before others, that they may see your good deeds and glorify your Father in heaven."),
            new Reference("Bible", "Psalms", "23", "1-6", "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul. He guides me along the right paths for his name’s sake. Even though I walk through the darkest valley, I will fear no evil, for you are with me; your rod and your staff, they comfort me. You prepare a table before me in the presence of my enemies. You anoint my head with oil; my cup overflows. Surely your goodness and love will follow me all the days of my life, and I will dwell in the house of the Lord forever."),
            new Reference("Bible", "Proverbs", "3", "5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Reference("Bible", "Romans", "12", "1-2", "Therefore, I urge you, brothers and sisters, in view of God’s mercy, to offer your bodies as a living sacrifice, holy and pleasing to God—this is your true and proper worship. Do not conform to the pattern of this world, but be transformed by the renewing of your mind. Then you will be able to test and approve what God’s will is—his good, pleasing and perfect will."),

            // Add Book of Mormon scriptures
            new Reference("Book of Mormon", "2 Nephi", "2", "25-27", "Adam fell that men might be; and men are, that they might have joy. And the Messiah cometh in the fulness of time, that he may redeem the children of men from the fall. And because that they are redeemed from the fall they have become free forever, knowing good from evil; to act for themselves and not to be acted upon, save it be by the punishment of the law at the great and last day, according to the commandments which God hath given."),
            new Reference("Book of Mormon", "Mosiah", "2", "17-18", "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God. Behold, ye have called me your king; and if I, whom ye call your king, do labor to serve you, then ought not ye to labor to serve one another?"),
            new Reference("Book of Mormon", "Alma", "7", "11-13", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."),
        };
        
        int randomIndex = new Random().Next(references.Count);
        Reference reference = references[randomIndex];

        Scripture scripture = new Scripture(reference);
        Console.WriteLine(scripture.ToString());

        string userInput = "";
        Console.Write("Hit 'Enter' or type 'quit' to end the program: ");
        userInput = Console.ReadLine();

        while (userInput != "quit")
        {
        scripture.HideWords();
        Console.WriteLine(scripture.ToString());

        if (scripture.IsWholeScriptureHidden()) 
        {
            break;
        }

        Console.Write("Hit 'Enter' or type 'quit' to end the program: ");
        userInput = Console.ReadLine();
        }
    }
}