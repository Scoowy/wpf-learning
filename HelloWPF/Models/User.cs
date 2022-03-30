using System.ComponentModel;
using System.Runtime.CompilerServices;
using HelloWPF.Annotations;

namespace HelloWPF.Models;

public class User : INotifyPropertyChanged {
    private string _name = null!;
    private int _age = 0;
    private string _mail = null;
    private SexType? _sex = null;

    public string Name {
        get => this._name;
        set {
            if (this._name == value) return;
            this._name = value;
            this.OnPropertyChanged();
        }
    }

    public int Age {
        get => this._age;
        set {
            if (this._age == value) return;
            this._age = value;
            this.OnPropertyChanged();
        }
    }

    public string Mail {
        get => this._mail;
        set {
            if (this._mail == value) return;
            this._mail = value;
            this.OnPropertyChanged();
        }
    }

    public SexType? Sex {
        get => this._sex;
        set {
            if (this._sex == value) return;
            this._sex = value;
            this.OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString() {
        return $"{this.Name}, {this.Age} years old";
    }
}