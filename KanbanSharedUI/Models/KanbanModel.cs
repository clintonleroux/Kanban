using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanSharedUI.Models
{
    public class KanbanModel
    {
        public KanbanModel()
        {
            Columns = new();
            Cards = new();
        }
        public List<ColumnModel> Columns { get; set; }
        public List<CardModel> Cards { get; set; }
        public void AddColumn(int columnID)
        {
            KanbanSharedUI.Models.ColumnModel column = new()
            {
                ID = columnID.ToString(),
                Title = "Column Title",
            };
            Columns.Add(column);
        }

        public void AddCard()
        {
            KanbanSharedUI.Models.CardModel card = new()
            {
                ColumnID = "0",
                Title = "Card Title",
                Description = "description",
                IsEditable = true
            };
            Cards.Add(card);
        }
    }
}