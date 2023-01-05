const axios = require('axios');

export async function getAllUsers() {

    // const response = await axios.get('/api/users');
    // return response.data;
    var config = {
        method: 'get',
        url: 'https://localhost:5001/api/Employees',
        headers: { }
      };
      
      axios(config)
      .then(function (response) {
        return response.data
      })
      .catch(function (error) {
        console.log(error);
      });
}

export async function createUser(data) {
    const response = await axios.post(`/api/user`, {user: data});
    return response.data;
}