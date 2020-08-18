import React, { useEffect, useState } from 'react';

import axios from 'axios';

const Members = () => {
        const [members, setMembers] = useState([]);

        useEffect(() => {
                axios.get('https://localhost:5001/api/member/')
                        .then((r) => {
                                setMembers(r.data);
                        })
            }, []);

        return(
                <div>
                        {members.map(({name, surname}) => (
                                <li>{name} {surname}</li>                                
                        ))}
                </div>
        );
}

export default Members;