using System.ComponentModel;
using System.Runtime.CompilerServices;

public class UserModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public int IdUser { get; set; }
    public int Idade { get; set; }
    private Color _colorLabel { get; set; } = new();
    public Color ColorLabel
    {
        get => _colorLabel;
        set
        {
            if (_colorLabel != value)
            {
                _colorLabel = value;
                OnPropertyChanged();
            }
        }
    }
}