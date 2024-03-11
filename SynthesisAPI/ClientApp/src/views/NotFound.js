import { Link } from "react-router-dom";

export default function NotFound()
{
    return(
        <>
            <h2>Incorrect path</h2>
            <Link to="/">Return to home</Link>
        </>
    );
}