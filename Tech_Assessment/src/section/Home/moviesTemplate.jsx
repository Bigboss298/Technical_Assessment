import { Link } from 'react-router-dom';

export default function SearchResult({ data }) {
    if (!data) return <h1>Enter the title above</h1>;
    
    if(data.response === "False") return <h1>{data ? data.error : "No search results found."}</h1>
    

    const { genre, title, year, type, imdbID } = data;

    return (
        <div className="movieCard">
            <div>
                <Link to={`/singlemovie/${imdbID}`}>
                <h1>{title}</h1>
                </Link>
            </div>
            <div className='subMovieCard'>
                <li>{year}</li>
                <li>{genre}</li>
                <li>{type}</li>
            </div>

        </div>
    )
}