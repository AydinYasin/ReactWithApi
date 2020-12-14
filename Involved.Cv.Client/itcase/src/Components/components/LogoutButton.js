import React from 'react';
import { useAuth0 } from '@auth0/auth0-react';
import { Button } from 'react-bootstrap';
import { FaBeer, FaUser, FaUserPlus } from 'react-icons/fa';
import { Link } from 'react-router-dom'

const LogoutButton = () => {
    const { logout, isAuthenticated } = useAuth0();
    return (
        isAuthenticated && (
        <Button variant="success" style={{ margin: 10 }} onClick={() => logout()}><FaUser />Uitloggen</Button>
        )
    )
}

export default LogoutButton
