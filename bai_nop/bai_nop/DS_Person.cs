using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_nop
{
    class DS_Person
    {
        public List<Person> dsPerson = new List<Person>
        {
            new Person{ Id=1, Name="Thien", Desc="Em dung chung mot dieu cuoi", ImgURL="https://images.unsplash.com/photo-1565841533903-781b91926dd1?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=334&q=80" },
            new Person{ Id=2, Name="BongLV", Desc="Cho cả hàng triệu người.", ImgURL="https://images.unsplash.com/photo-1554935208-2bc12b516985?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80"},
            new Person{ Id=3, Name="Long", Desc="Rang anh co noi 1, ", ImgURL="https://images.unsplash.com/photo-1611817757571-75fe5c08ffd9?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=334&q=80"},
            new Person{ Id=0, Name="Tran", Desc="Thì em cũng chẳng thể hiểu mười", ImgURL="https://images.unsplash.com/photo-1554548263-f0092d71f0bb?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=332&q=80"}
        };
        public List<Person> GetDS() {
            return dsPerson;
        }
        public Person GetPersonSelected(int psID)
        {
            return dsPerson.SingleOrDefault(ds => ds.Id == psID);
        }
    }
}
