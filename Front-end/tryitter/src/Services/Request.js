// eslint-disable-next-line import/no-extraneous-dependencies
import axios from 'axios';

const baseURL = process.env.REACT_APP_API_URL || 'http://localhost:3001';
console.log(baseURL);

const loginUser = async (endpoint, body) => {
  const { data } = await axios.post((baseURL + endpoint), body);
  return data;
};

const PostsUser = async (endpoint, params) => {
  console.log(endpoint);
  console.log(params);
  console.log(`${baseURL}${endpoint}${params}`);
  const result = await axios.get(`${baseURL}${endpoint}${params}`);
  console.log('>>>>>', result);
  return result;
};

export {
  loginUser,
  PostsUser,
};
