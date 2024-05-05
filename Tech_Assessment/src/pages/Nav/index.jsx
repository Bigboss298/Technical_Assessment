import { Link } from 'react-router-dom';
import '../../App.css';
export default function Navbar() {
    return (
        <div className="nav">
            <div className='brand'>
                <p className='brandName'>Technical Assesment</p>
            </div>
            <ul>
                <Link to='/' className='link'>
                    Home
                </Link>
                <Link to='/history' className='link'>
                    History
                </Link>
            </ul>
        </div>
    )
}