

export default function SingleMovieTemplate({ data }) {
    const { title, year, country, released, genre, poster, rated, plot, imdbID, awards, actors } = data;
    return (
        <div className='singleMovieBox'>
            <div className="singlecontainer">
                <div className='singleImage'>
                    <img src={poster} alt="poster" />
                </div>
                <div className='singleText'>
                    <p>Title :{title} </p>
                    <p>Year : {year} </p>
                    <p>Country : {country}</p>
                    <p>Released : {released} </p>
                    <p>genre : {genre}</p>
                    <p>Rated : {rated} </p>
                    <p>Description: {plot} </p>
                    <p>imdbID : {imdbID} </p>
                    <p>Awards : {awards} </p>
                    <p>Actors : {actors} </p>
                </div>
            </div>
        </div>
    )
}


