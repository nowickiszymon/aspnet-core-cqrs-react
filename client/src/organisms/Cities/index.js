import React, {useEffect, useState} from 'react';

import axios from 'axios';

const Cities = () => {
        const [cities, setCities] = useState([]);

        useEffect(() => {
                axios.get('https://localhost:5001/api/city/')
                        .then((r) => {
                                setCities(r.data);
                        })
            }, []);
            
        return(
                <div>
                        {cities.map(({name, size}) => (
                                <ul>
                                        <li>City name : {name}</li>         

                                        <li>City size peoples : {size}</li>        
                                </ul>                        
                        ))}
                </div>
        );
}

export default Cities;