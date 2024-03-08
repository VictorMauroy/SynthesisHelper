import { Link } from "react-router-dom";
import HomePage from "./HomePage";

export default function NotFound()
{
    return(
        <>
            <h2>Incorrect path</h2>
            <Link to={ <HomePage /> }>Return to home</Link>
        </>
    );
}