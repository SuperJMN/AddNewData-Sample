using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;

namespace App2
{
    public class ViewModel : ReactiveObject
    {
        private bool isAddUserPanelVisible;

        public ViewModel()
        {
            Messages = new ObservableCollection<Message>()
            {
                new Message()
                {
                    Sender = "Yo",
                    Recipient = "Pietro",
                },
                new Message()
                {
                    Sender = "Ana",
                    Recipient = "José",
                },
            };

            ShowAddPanelCommand = ReactiveCommand.Create(() => IsAddUserPanelVisible = true);
            AddCommand = ReactiveCommand.Create(() =>
            {
                Messages.Add(new Message(Sender, Recipient));
                IsAddUserPanelVisible = false;
            });

            CancelCommand = ReactiveCommand.Create(() =>
            {
                IsAddUserPanelVisible = false;
            });
        }

        public ReactiveCommand<Unit, Unit> AddCommand { get; set; }

        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }

        public ReactiveCommand<Unit, bool> ShowAddPanelCommand { get; set; }


        public string Sender { get; set; }

        public string Recipient { get; set; }

        public ObservableCollection<Message> Messages { get; }

        public bool IsAddUserPanelVisible
        {
            get => isAddUserPanelVisible;
            set => this.RaiseAndSetIfChanged(ref isAddUserPanelVisible, value);
        }
    }
}