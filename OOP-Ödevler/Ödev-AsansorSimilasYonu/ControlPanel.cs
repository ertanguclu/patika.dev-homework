public class ControlPanel
{
    private int panelId;
    private List<Button> buttons;

    public ControlPanel(int panelId)
    {
        this.panelId = panelId;
        buttons = new List<Button>();
        // Initialize buttons
        buttons.Add(new Button(0, ButtonType.Destination));
        buttons.Add(new Button(1, ButtonType.OpenDoor));
        buttons.Add(new Button(2, ButtonType.CloseDoor));
        buttons.Add(new Button(3, ButtonType.Emergency));
    }

    public void PressButton(Button button)
    {
        // Logic to handle button press
        switch (button.Type)
        {
            case ButtonType.Destination:
                // Set destination floor
                break;
            case ButtonType.OpenDoor:
                // Open doors
                break;
            case ButtonType.CloseDoor:
                // Close doors
                break;
            case ButtonType.Emergency:
                // Handle emergency
                break;
            default:
                break;
        }
    }
}

public enum ButtonType
{
    Destination,
    OpenDoor,
    CloseDoor,
    Emergency
}

public class Button
{
    private int buttonId;
    private ButtonType type;

    public Button(int buttonId, ButtonType type)
    {
        this.buttonId = buttonId;
        this.type = type;
    }

    public ButtonType Type
    {
        get { return type; }
    }
}
