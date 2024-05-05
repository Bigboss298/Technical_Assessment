

export default function SingleMovieTemplate({ data }) {
    const { title, year, country, released, genre, poster, rated, plot, imdbID, awards, actors, metaScore } = data;
    return (
        <div className='singleMovieBox'>
            <div className="singlecontainer">
                <div className='singleImage'>
                    <img src={poster} alt="poster" />
                </div>
                <div className='singleText'>
                    <p><b>Title</b> :{title} </p>
                    <p><b>Year</b> : {year} </p>
                    <p><b>Country</b> : {country}</p>
                    <p><b>Released</b> : {released} </p>
                    <p><b>Genre</b> : {genre}</p>
                    <p><b>Rated</b> : {rated} </p>
                    <p><b>Description</b> : {plot} </p>
                    <p><b>imdbID</b> : {imdbID} </p>
                    <p><b>Awards</b> : {awards} </p>
                    <p><b>Actors</b> : {actors} </p>
                    <p><b>Meta Score</b> : {metaScore} </p>
                </div>
            </div>
        </div>
    )
}


