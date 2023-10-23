class Flight
{
    constructor(_flightFromJson) 
    {
        Object.assign(this, _flightFromJson);
    }
}

export { Flight }