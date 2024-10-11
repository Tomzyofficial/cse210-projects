using System;

class Program
{
  static void Main(string[] args)
  {
    List<Video> videos = new List<Video>();

    // List of videos
    Video video1 = new Video("Next-Auth on App Router - Solid Auth, Super fast", "Kelvin Hart", 600);
    video1.AddComment(new Comment("Kennedy", "Great explanation, thank you!"));
    video1.AddComment(new Comment("Jeff", "This was really helpful! thanks for the tips!"));
    video1.AddComment(new Comment("Charles", "Can you cover more advanced topics next?"));
    videos.Add(video1);

    Video video2 = new Video("She took over her dad's company", "Vista Tv", 900);
    video2.AddComment(new Comment("Tracy", "This movie is amazing!"));
    video2.AddComment(new Comment("Janet", "We should have more movies like this."));
    video2.AddComment(new Comment("Anne", "When is the continuation coming up?"));
    videos.Add(video2);

    Video video3 = new Video("Top 10 Travel Destinations", "Jeff", 1200);
    video3.AddComment(new Comment("George", "I've been to #3, and it was breathtaking!"));
    video3.AddComment(new Comment("Hannah", "Adding these places to my bucket list!"));
    video3.AddComment(new Comment("Cornelius", "Would love to see a part 2."));
    videos.Add(video3);

    foreach (var video in videos)
    {
      video.Display();
    }

  }
}

class Video
{
  private string _title;
  private string _author;
  private int _lengthInSecs;
  private List<Comment> comments;

  public Video(string title, string author, int length)
  {
    this._title = title;
    this._author = author;
    this._lengthInSecs = length;
    this.comments = new List<Comment>();
  }

  public void AddComment(Comment comment)
  {
    comments.Add(comment);
  }

  public int GetNumberOfComments()
  {
    return comments.Count;
  }

  public void Display()
  {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_lengthInSecs} seconds");
    Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

    Console.WriteLine("Comments:");

    foreach (var comment in comments)
    {
      comment.Display();
    }

    Console.WriteLine();
  }
}

class Comment
{
  private string _name;
  private string _text;

  public Comment(string name, string text)
  {
    this._name = name;
    this._text = text;
  }

  public void Display()
  {
    Console.WriteLine($"{_name}: {_text}");
  }
}



