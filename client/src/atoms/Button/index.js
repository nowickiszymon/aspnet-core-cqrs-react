import React from 'react';

import './style.scss';

const Button = (props) => {

        return(
        <button className="button" onClick={props.click}>
                        {props.title}
        </button>
        );
}

export default Button;