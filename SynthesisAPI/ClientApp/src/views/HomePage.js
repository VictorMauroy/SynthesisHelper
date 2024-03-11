import logo from '../logo.svg';
import '../App.css';
import { Link } from 'react-router-dom';

export default function HomePage() {
    return(
        <div className="App">
            <header className="App-header">
                <img src={logo} className="App-logo" alt="logo" />
                <p>
                Edit <code>src/App.js</code> and save to reload.
                </p>
                <a
                className="App-link"
                href="https://reactjs.org"
                target="_blank"
                rel="noopener noreferrer"
                >
                Learn React
                </a>
                <br />

                <Link to="/Monster/e2bc8649-c032-4c85-b98c-eca14d58a860">MONSTER GO !</Link>
                <Link to="/Monsters">All the monsters</Link>
            </header>
        </div>
    );
}