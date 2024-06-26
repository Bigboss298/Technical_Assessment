﻿namespace Technical_Assessment_API.Model.Dto
{
    public class DetailedMovieDto
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Country { get; set; }
        public string? Released { get; set; }
        public string? Genre { get; set; }
        public string? Poster { get; set; }
        public string? Rated { get; set; }
        public string? Plot { get; set; }
        public string? MetaScore { get; set; }
        public string? imdbRating { get; set; }
        public string? imdbVotes { get; set; }
        public string? imdbID { get; set; }
        public bool Response { get; set; }
        public string? Actors { get; set; }
        public string? Awards { get; set; }
    }

    public class MovieByTitleDto
    {
        public string? Title { get; set; }
        public string? Year { get; set;}
        public string? Genre { get; set; }
        public string? Type { get; set; }
        public string? imdbID { get; set; }
    }
}
