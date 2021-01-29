using System;
using System.Collections.Generic;
using System.Text;

namespace bai_nop
{
    class Person
    {
        private int id;
        private string name;
        private string desc;
        private string imgURL;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string ImgURL { get => imgURL; set => imgURL = value; }
    }
}
