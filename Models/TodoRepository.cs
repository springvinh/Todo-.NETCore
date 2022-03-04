namespace Todo.Models;

public static class TodoRepository {

    private static List<TodoModel> _Todos = new List<TodoModel>();

    public static IEnumerable<TodoModel> Todos => _Todos;

    public static void Create(string Title, string Content, string Author) {
        _Todos.Add(new TodoModel(Title, Content, Author));
    } 

    public static void Delete(TodoModel todo) {
        _Todos.Remove(todo);
    }

    public static void Update(TodoModel todo) {

        if (_Todos == null) return;

        TodoModel? match = _Todos.Find(element => element.ID == todo.ID);

        if (match != null) {
            match = todo;
        }

    }

}