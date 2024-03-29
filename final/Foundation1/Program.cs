using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Comment cat1 = new Comment("Red_Rubik", "Radical");
        Comment cat2 = new Comment("JBull", "Kittykat Rockstars...");
        Comment cat3 = new Comment("pippersMcdippers", "O Autmun my Autmun!");
        Comment cat4 = new Comment("Mulch5000", "Pussy cat go 'meow'");
        Video catVideo = new Video("Funny Cat Montage", "Pipsqueek", "12:36", new List<Comment>() {cat1, cat2, cat3, cat4});

        Comment game1 = new Comment("Bobiejr", "Bug got clipped on.");
        Comment game2 = new Comment("Qmackdown", "Excited to get Helldivers 2 on my birthday. This game looks amazing!");
        Comment game3 = new Comment("P1SarSki", "This game does microtransactions the way they were meant to be done, so refreshing man.");
        Video gamingVideo = new Video("HellDivers 2 Gameplay 4k 1080p", "PhiPhi00", "20:27", new List<Comment>() {game1, game2, game3});

        Comment mov1 = new Comment("Wanderer1017", "Loved watching this with my dad as a kid.");
        Comment mov2 = new Comment("DM9000", "Rare that the sequel is better than the original but this is one of those cases.");
        Comment mov3 = new Comment("AMacDaddy99", "Anyone else feel flabbergasted and discombublated during the entire runtime?");
        Video movieVideo = new Video("Ghostbusters 6 Movie Review", "DaddyCaden", "8:12", new List<Comment>() {mov1, mov2, mov3});

        List<Video> videos = new List<Video>() {catVideo, gamingVideo, movieVideo};
        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayInfo());
            video.DisplayComments();
        }
    }
}