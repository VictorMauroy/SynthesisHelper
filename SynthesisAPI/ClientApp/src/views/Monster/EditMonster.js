import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import FamilySelector from "../../components/forms/familySelector";
import RankSelector from "../../components/forms/RankSelector";

export default function EditMonster() {
    let { monsterId } = useParams();
    const [monster, setMonster] = useState(null);
    const [errorMessage, setErrorMessage] = useState(null);
    const monsterApiUrl = 'http://localhost:5051';

    useEffect( () => {
        const fetchData = async () => {
            try {
                const res = await fetch(monsterApiUrl + "/Monster/" + monsterId);

                if(!res.ok){
                    throw new Error("Cannot reach monster API");
                }

                const resToJson = await res.json();
                setMonster(resToJson);
            } catch(error) {
                setErrorMessage(error.message);
            }
        };

        fetchData();
    }, [monsterId]);

    function handleNameChange(e) {
        setMonster({
            ...monster,
            name: e.target.value
        });
    }

    function handleGameIDChange(e) {
        setMonster({
            ...monster,
            gameID: e.target.value
        });
    }

    function handleDetailsChange(e) {
        setMonster({
            ...monster,
            details: e.target.value
        });
    }

    function handleStatisticsChange(e, index) {
        setMonster({
            ...monster,
            statistics: monster.statistics.map((stat, i) => {
                if(i === index) {
                    return e.target.value;
                } else {
                    return stat;
                }
            })
        });
    }

    if(monster != null) {
        return(
            <div>
    
                <h2>Editing {monster.name}</h2>
    
                <form>

                    <div className="form-group">
                        <label className="form-label">Name</label>
                        <input type="text" name="monsterName" className="form-control" onChange={handleNameChange} value={monster.name} aria-describedby="nameHelpBlock" />
                        {/* <div id="nameHelpBlock" class="form-text">
                            Your password must be 8-20 characters long, contain letters and numbers, and must not contain spaces, special characters, or emoji.
                        </div> */}
                    </div>

                    <div className="form-group">
                        <label className="form-label">Game ID</label>
                        <input type="text" name="gameID" className="form-control" onChange={handleGameIDChange} value={monster.gameID} />
                    </div>
                    
                    {/* Penser à récupérer les valeurs et les stocker en onChange */}
                    <FamilySelector family={monster.family} />

                    <RankSelector rank={monster.rank} />

                    <div className="form-group">
                        <label className="form-label">Details</label>
                        <input type="text" name="details" className="form-control" onChange={handleDetailsChange} value={monster.details} />
                    </div>

                    {/* Réussir à créer de quoi mettre à jour les statistiques */}
                    <div className="input-group">
                        <span className="input-group-text">Statistics</span>
                        <input type="text" value={monster.statistics[0]} onChange={(evt) => handleStatisticsChange(evt, 0)} aria-label="Health" className="form-control" />
                        {/* Oops, I forgot mana pool */}
                        <input type="text" value={monster.statistics[1]} onChange={(evt) => handleStatisticsChange(evt, 1)} aria-label="Attack" className="form-control" />
                        <input type="text" value={monster.statistics[2]} onChange={(evt) => handleStatisticsChange(evt, 2)} aria-label="Defense" className="form-control" />
                        <input type="text" value={monster.statistics[3]} onChange={(evt) => handleStatisticsChange(evt, 3)} aria-label="Agility" className="form-control" />
                        <input type="text" value={monster.statistics[4]} onChange={(evt) => handleStatisticsChange(evt, 4)} aria-label="Wisdom" className="form-control" />
                    </div>
                    <div  className="form-text">
                        Enter the statistics in the order: Health, Attack, Defense, Agility, Wisdom.
                    </div>
    
                </form>
            </div>
        );
    } 
    else if(errorMessage != null) {
        <div>
            <h2>Monster edition: failed</h2>
            <p>An error occurred: {errorMessage}</p>
        </div>
    } 
    else {
        return(
            <div>
                <h2>Monster edition loading...</h2>
            </div>
        );
    }
    
}