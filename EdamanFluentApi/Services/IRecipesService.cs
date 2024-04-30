﻿using EdamanFluentApi.Model;
using System.Collections.ObjectModel;

namespace EdamanFluentApi.Services
{
    public interface IRecipesService
    {
        Task<ObservableCollection<Recipe>> SearchRecipes(string ingredient, string diet, string allergie);
    }
}