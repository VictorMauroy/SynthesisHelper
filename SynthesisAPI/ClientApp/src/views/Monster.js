import { useParams } from "react-router-dom";


export default function Monster() {
    let { monsterId } = useParams();
    
    return(
        <p>
        There is a monste here!
        </p>
    );
}