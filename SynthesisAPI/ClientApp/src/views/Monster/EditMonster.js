import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import FamilySelector from "../../components/forms/familySelector";

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

    if(monster != null) {
        return(
            <div>
    
                <h2>Editing {monster.name}</h2>
    
                <form>
                    
                    <label for="monsterName" class="form-label">Name</label>
                    <input type="text" id="monsterName" class="form-control" value={monster.name} aria-describedby="nameHelpBlock" />
                    <div id="nameHelpBlock" class="form-text">
                        Your password must be 8-20 characters long, contain letters and numbers, and must not contain spaces, special characters, or emoji.
                    </div>

                    <FamilySelector family={monster.family} />
    
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