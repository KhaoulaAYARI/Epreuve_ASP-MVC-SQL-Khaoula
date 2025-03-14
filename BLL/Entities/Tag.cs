using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Tag
    {

        public Guid Tag_Id { get; set; }
        public string Nom { get; set; }
        public string? Description { get; set; }


        public Tag(Guid tag_Id, string nom, string? description)
        {
            Tag_Id = tag_Id;
            Nom = nom;
            Description = description;
        }
    }
}
