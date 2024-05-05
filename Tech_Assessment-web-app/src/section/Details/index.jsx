import SingleMovieTemplate from "./singleMovieTemplate";
import { useSearchs } from "../../Zustand/searchSlice";
import { useEffect } from "react";
import { useParams } from "react-router-dom";

export default function SingleMovieInfo() {
    const { imdbID } = useParams();
    const { get, singleMovie, fetchSingleMovie } = useSearchs();

    useEffect(() => {
        fetchSingleMovie(imdbID);
    }, [imdbID, fetchSingleMovie]);

    const { loading } = get;

    const { data } = singleMovie;

    if (loading) return (<h1>Loading...</h1>)
    if (!data) return (<h1>Oops, No Data</h1>)

    return (
        <SingleMovieTemplate data={data} />
    )
}