## C# skeleton for SkedItem suggested by ChatGPT
public class SkedItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty; // Markdown or HTML
    public DateTimeOffset CreationTime { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset LastModified { get; set; } = DateTimeOffset.Now;

    public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;
    public string? IconKey { get; set; }

    public Guid? ParentId { get; set; }
    public List<Guid> ChildrenIds { get; set; } = new();

    public StatusLevel Status { get; set; } = StatusLevel.Pending;
    public List<string> Tags { get; set; } = new();

    public DateTimeOffset? DueDate { get; set; }
    public DateTimeOffset? ReminderTime { get; set; }

    public bool IsCollapsed { get; set; } = false;
    public int OrderIndex { get; set; } = 0;

    public Dictionary<string, string> CustomFields { get; set; } = new();
}

public enum PriorityLevel { Low, Normal, High, Critical }
public enum StatusLevel { Pending, Done, Archived }

## Markdown Rendering for SkedItem Description
1. Markdown Rendering (Viewer)
### Markdig + WebBrowser / WebView2

Markdig: A fast, fully-featured Markdown parser for .NET 

Usage:

* Convert Markdown → HTML
* Display in WinForms WebBrowser or WebView2 control

Pros:
* Highly customizable
* Supports GitHub-flavored Markdown
* Can apply your own CSS

Cons:
* WebView2 adds a bit of dependency (~50–100 MB runtime)

### MarkdownViewer for WinForms (NuGet)

* Lightweight WinForms control for Markdown
* Simple rendering without full HTML engine

NuGet: MarkdownViewer
 - Pros: simple, no WebView2
 - Cons: limited styling, basic Markdown only

### RichTextBox + Markdown → RTF

Convert Markdown to RTF and display in RichTextBox

Tools: Markdig + RtfPipe

Pros: fully offline, native WinForms control

Cons: limited Markdown support, custom rendering may be tricky

2. Markdown Editing
### Custom Markdown editor

Use a TextBox / RichTextBox for input

Render Markdown preview live in WebView2 or MarkdownViewer

You get full control over editing and formatting

### Pattern:

Split-view: Left = Markdown editor, Right = Markdown preview

Update preview on TextChanged (with small debounce)

Use Markdig for conversion
