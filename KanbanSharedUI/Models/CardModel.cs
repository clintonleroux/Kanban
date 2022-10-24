using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanSharedUI.Models;
public class CardModel
{
    public int ID { get; set; }
    public string ColumnID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsEditable { get; set; }
}