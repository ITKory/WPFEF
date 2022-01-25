using System;
using System.Collections.Generic;
using System.ComponentModel;
using WPFL.lib;

namespace WPFEF
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private DBConnection db;
        private List<Game> games;
        private string gName, pName, sName;
        DateTime pDate;

        public ViewModel()
        {
            db = new();
            games = new(db.TableGames);
        }

        void Update(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public List<Game> Games
        {
            get { return games; }
            set
            {
                games = value;
                Update("Games");
            }
        }

        public string Game
        {
            get { return gName; }
            set
            {
                gName = value;
                Update("Game");
            }
        }
        public string Publisher
        {
            get { return pName; }
            set
            {
                pName = value;
                Update("Publisher");
            }
        }
        public string Style
        {
            get { return sName; }
            set
            {
                sName = value;
                Update("Style");
            }
        }
        public DateTime PubliSDate
        {
            get { return pDate; }
            set
            {
                pDate = value;
                Update("PubliSDate");
            }
        }

        public MyCommand AddGame => new MyCommand(_ =>
        {
            db.TableGames.Add(new Game
            {
                Name = gName,
                Publisher = pName,
                Style = sName,
                publiSDate = pDate,

            });
            db.SaveChanges();
            games = new(db.TableGames);
            Update("Games");
        });


    }
}
