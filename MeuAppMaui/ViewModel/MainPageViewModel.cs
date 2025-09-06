using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Input;
using Metal;

namespace MeuAppMaui.ViewModel;

public class MainPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private ObservableCollection<UserModel> _listIdade { get; set; } = new();

    public ObservableCollection<UserModel> ListIdade
    {
        get => _listIdade;
        set
        {
            if (_listIdade != value)
            {
                _listIdade = value;
                OnPropertyChanged();
            }
        }
    }

    //OBRIGATORIO TER O _ NO PRIVATE
    //OBRIGATORIO TER LETRA MAIUSCULA EM PROP PUBLICA
    // private int _idade { get; set; } = new();
    // public int Idade
    // {
    //     get => _idade;
    //     set
    //     {
    //         if (_idade != value)
    //         {
    //             _idade = value;
    //             OnPropertyChanged();
    //         }
    //     }
    // }

    // private string _mensagemIdade { get; set; }
    // public string MensagemIdade
    // {
    //     get => _mensagemIdade;
    //     set
    //     {
    //         if (_mensagemIdade != value)
    //         {
    //             _mensagemIdade = value;
    //             OnPropertyChanged();
    //         }
    //     }
    // }

    // private Color _colorLabel { get; set; } = new();
    // public Color ColorLabel
    // {
    //     get => _colorLabel;
    //     set
    //     {
    //         if (_colorLabel != value)
    //         {
    //             _colorLabel = value;
    //             OnPropertyChanged();
    //         }
    //     }
    // }

    //TODO COMANDO PRECISA TERMINAR COM COMMAND
    public ICommand VerificarIdadeCommand { get; set; }

    public MainPageViewModel()
    {
        ObservableCollection<UserModel> listaIdade = CarregaListaApi();

        foreach (var item in listaIdade)
        {
            if (item.Idade >= 18)
            {
                item.ColorLabel = Colors.Green;
            }
            else
            {
                item.ColorLabel = Colors.Red;
            }
        }

        //VerificarIdadeCommand = new Command(CalcularIdade);
    }

    // public void CalcularIdade()
    // {
    //     if (Idade >= 18)
    //     {
    //         MensagemIdade = "Maior de idade";
    //         ColorLabel = Colors.Green;
    //     }
    //     else
    //     {
    //         MensagemIdade = "Menor de idade";
    //         ColorLabel = Colors.Red;
    //     }
    // }

    public ObservableCollection<UserModel> CarregaListaApi()
    {
        ListIdade.Add(new UserModel
        {
            IdUser = 0,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 1,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 2,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 3,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 4,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 5,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 6,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 7,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 8,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 9,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 10,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 11,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 12,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 13,
            Idade = 14
        });
        ListIdade.Add(new UserModel
        {
            IdUser = 14,
            Idade = 19
        });

        return ListIdade;
    }
}