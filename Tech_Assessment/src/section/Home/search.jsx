import '../../App.css';
import { useState } from 'react';
import { useSearchs } from '../../Zustand/searchSlice';

export default function SearchBox() {
    const { fetchMovie } = useSearchs();
    const [title, setTitle] = useState("");


    const handleChange = (e) => {
        setTitle(e.target.value);
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        fetchMovie(title);

        setTitle("");
    };
    return (
        <div className="searchBox">
            <form onSubmit={handleSubmit}>
                <input type="search" required name="title" value={title} onChange={handleChange} id="search" className='searchInput' />
                <button type="submit" className='submitButton'>search</button>
            </form>
        </div>
    )
}