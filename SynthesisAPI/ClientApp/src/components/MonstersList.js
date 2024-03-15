import { useEffect, useState } from "react";
import MonsterCard from "./MonsterCard.js";

export default function MonstersList() {
    const [monsterList, setMonsterList] = useState(null); 
    const [errorMessage, setErrorMessage] = useState(null);
    
    useEffect( () => {
        const fetchData = async () => {
            try {
                const res = await fetch("http://localhost:5051/Monster");

                if(!res.ok){
                    throw new Error("Cannot reach monster API");
                }

                const resToJson = await res.json();
                setMonsterList(resToJson);
            } catch(error) {
                setErrorMessage(error.message);
            }
        };

        fetchData();
    }, []);

    return(
        <div>
                { errorMessage && 
                    <p>The application encountered an error: {errorMessage} </p> }
                    
                { monsterList && 
                    monsterList.map(data => (
                        <MonsterCard key={data.monsterId} id={data.monsterId} />
                    ))
                }
        </div>
    );
}