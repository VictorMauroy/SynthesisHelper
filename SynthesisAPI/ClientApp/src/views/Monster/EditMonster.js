import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

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
    
    return(
        <form>
        </form>
    );
}