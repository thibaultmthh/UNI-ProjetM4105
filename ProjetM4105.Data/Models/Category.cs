using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetM4105.Data.Models
{
    public enum Category
    {
        Entree = 0,
        Plat = 1,
        Boisson = 2,
        Dessert = 3
    }
}
