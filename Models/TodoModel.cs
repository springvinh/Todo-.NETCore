public class TodoModel {
    public string? ID { get; set; }
    public string? Title {get; set;}
    public string? Content {get; set;}
    public DateTime? Time {get; set;}
    public string? Author { get; set; }
    public bool? IsDone {get; set;}

    public TodoModel(string Title, string Content, string Author) {
        this.ID = Utils.RandomID();
        this.Title = Title;
        this.Content = Content;
        this.Author = Author;
        this.Time = DateTime.Now;
        this.IsDone = false;
    }
}