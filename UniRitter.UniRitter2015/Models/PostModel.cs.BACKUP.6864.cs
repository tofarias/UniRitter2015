using System;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> dbf699c40537ae3ac77dd49f69d701a3ccdbb100
using System.ComponentModel.DataAnnotations;
namespace UniRitter.UniRitter2015.Models
{
    public class PostModel : IModel
    {
        public Guid? id { get; set; }

        [Required]
<<<<<<< HEAD
        [MaxLength(400)]
=======
        [MaxLength(4000)]
>>>>>>> dbf699c40537ae3ac77dd49f69d701a3ccdbb100
        public string body { get; set; }

        [Required]
        [MaxLength(100)]
        public string title { get; set; }

<<<<<<< HEAD
        public PersonModel author { get; set; }

        public string[] tags { get; set; }
=======
        public Guid authorId { get; set; }

        public IEnumerable<string> tags { get; set; }
>>>>>>> dbf699c40537ae3ac77dd49f69d701a3ccdbb100
    }
}
