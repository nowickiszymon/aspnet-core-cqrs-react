import React, { useState } from 'react';

import './style.scss';

// Material UI
import Grid from '@material-ui/core/Grid';
import Button from '../../atoms/Button';

// Components
import Cities from '../../organisms/Cities';
import Members from '../../organisms/Members';

const Index = () => {
        const [component, setComponent] = useState('members');
        
        const setCities = () => (
                setComponent('Cities')
        )
        
        const setMembers = () => (
                setComponent('members')
        )

        return(
                <div className="index">
                        <Grid container>
                                <Grid item xs={12} lg={2}>
                                        <nav>
                                                <Button title={"Cities"} click={setCities} />
                                                <Button title={"Members"} click={setMembers} />
                                        </nav>
                                </Grid>

                                <Grid item xs={12} lg={10}>
                                        <main>
                                                {component === 'Cities' && <Cities /> }
                                                {component === 'members' && <Members /> }
                                        </main>
                                </Grid>
                        </Grid>
                </div>
        );
}

export default Index;