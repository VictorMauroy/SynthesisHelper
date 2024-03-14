import '../App.css';
import MonstersList from '../components/MonstersList';

export default function Home() {
    return(
        <div className="App">
            <header className="App-header">
                <h1>Dragon Quest Monsters: The Dark Prince</h1>
                <h2>Monster List</h2>
                <MonstersList />
            </header>
        </div>
    );
}