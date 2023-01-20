using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using revanth.Models;

namespace revanth.rep
{
    public interface Ant
    {
        List<sam> GetAllEmployees();
        string updatemployee(sam r);
        string insertemployee(sam g);
        string deleteemploye(int d);
        string bulkdata(List<sam> l);
        sam getbyid(int id);
    }  
    public class Rat:Ant
    {
        RegisterEntities obj = new RegisterEntities();
        List<sam> Ant.GetAllEmployees()
        {
            var list = obj.Sams.Select(a => new sam()
            {
                name = a.name,
                college = a.college,
                age = a.age,
                ID = a.ID
            }).ToList<sam>();
            return list;
        }
        string Ant.updatemployee(sam r)
        {
            var nun = obj.Sams.Where(w => r.ID == w.ID).FirstOrDefault();
            if(nun!=null)
            {
                nun.name = r.name;
                nun.college = r.college;
                nun.age = r.age;
                nun.ID = r.ID;
            }
             obj.SaveChanges();
            obj.Dispose();
            return "Updated";
        }
        string Ant.insertemployee(sam g)
        {
            var nun = obj.Sams.Where(w => w.ID == g.ID).FirstOrDefault(); 
            if(nun==null)
            {
                obj.Sams.Add(new Sam
                {
                    name = g.name,
                    college = g.college,
                    age = g.age,
                    ID = g.ID
                }) ;
                
            }
            obj.SaveChanges();
            obj.Dispose();
            return "inserted";
        }
        string Ant.deleteemploye(int d)
        {
            var nun = obj.Sams.Where(w => w.ID == d).FirstOrDefault();
            if(nun !=null)
            {
                obj.Sams.Remove(nun);
            }
            obj.SaveChanges();
            obj.Dispose();
            return "deleted";
        }      
        string Ant.bulkdata(List<sam> l)
        {
            foreach (sam ele in l)
            {
                var nun = obj.Sams.Where(w => ele.ID == w.ID).FirstOrDefault();
                if(nun==null)
                {
                    obj.Sams.Add(new Sam
                    {
                        name = ele.name,
                        college = ele.college,
                        age = ele.age,
                        ID = ele.ID
                    });
                }
              
            }
            obj.SaveChanges();
            obj.Dispose();
            return "Bulk inserted";
        }

        sam Ant.getbyid(int ID)
        {
            var list = obj.Sams.Select(a => new sam()
            {
                name = a.name,
                college = a.college,
                age = a.age,
                ID = a.ID
            }).ToList<sam>();
            var ser = list.Where(e => e.ID == ID).FirstOrDefault();
            obj.Dispose();
            return ser;
        }
    }    
}
