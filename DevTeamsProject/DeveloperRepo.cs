﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();  //field given.  This is a variable inside the class that can be used anywhere in this class, ie can be used by any of these CRUD methods.
        //Syntax = content(List<>) name of field(_dev...) = whatever that is^^


        //Developer Create
        public void AddDeveloperToList(Developer developer)
        {
            //"entryways into our class"
            _developerDirectory.Add(developer);
        }

        //Developer Read  -- this enables us to see the list (directory) whenever we call the method called *GetDeveloperList*
        public List<Developer> GetDeveloperList()
        {
            return _developerDirectory;
        }

        //Developer Update
        public bool UpdateExistingDeveloper(string oldName, Developer newDev)
        {
            //Find the Developer
            Developer oldDev = GetDeveloperByName(oldName);

            //Update the Developer
            if(oldDev != null)
            {
                oldDev.Name = newDev.Name;
                oldDev.HasPluralSight = newDev.HasPluralSight;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Delete
        public bool RemoveDeveloperFromList(string name)
        {
            Developer developer = GetDeveloperByName(name);

            if(developer == null)
            {
                return false;
            }

            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(developer);

            if(initialCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        //Developer Helper (Get Developer by ID)
        //This method helps the Delete method by giving the ability to search by name
        public Developer GetDeveloperByName(string name)
        {
            foreach(Developer developer in _developerDirectory)
            {
                if(developer.Name == name)
                {
                    return developer;
                }
            }

            return null;
        }


    }
}
