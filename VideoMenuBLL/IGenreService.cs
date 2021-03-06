﻿using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuBLL.BusinessObjects;


namespace VideoMenuBLL
{
    public interface IGenreService
    {
        GenreBO Create(GenreBO gen);

        List<GenreBO> GetAll();
        GenreBO Get(int Id);
        GenreBO Update(GenreBO gen);
        GenreBO Delete(int Id);


    }
}
