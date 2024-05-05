import './App.css'
import Home from './pages/Home';
import { BrowserRouter, Routes, Route  } from 'react-router-dom';
import MovieInfo from './pages/Details/index';
import Navbar from './pages/Nav/index';
import History from './pages/History';
function App() {
  
  return (
    <BrowserRouter>
    <Navbar />
      <Routes>
          <Route exact path='/' element={ <Home /> } />
          <Route path='/singlemovie/:imdbID' element={ <MovieInfo /> } />
          <Route path='/history' element={ <History /> } />
      </Routes>

    </BrowserRouter>
  )
}

export default App;