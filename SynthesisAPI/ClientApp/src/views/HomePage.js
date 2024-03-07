import logo from '../logo.svg';
import '../App.css';
import { Link, Navigate } from 'react-router-dom';

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

                <Link to="/Monster/0">MONSTER GO !</Link>
            </header>
        </div>
    );
}