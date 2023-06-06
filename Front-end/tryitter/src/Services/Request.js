// eslint-disable-next-line import/no-extraneous-dependencies
import axios from 'axios';

const baseURL = process.env.REACT_APP_API_URL || 'http://localhost:3001';

const loginUser = async (endpoint, body) => {
  const { data } = await axios.post((baseURL + endpoint), body);
  return data;
};

const PostsUserid = async (endpoint, params) => {
  console.log(endpoint);
  console.log(params);
  console.log(`${baseURL}${endpoint}${params}`);
  const result = await axios.get(`${baseURL}${endpoint}${params}`);
  console.log('>>>>>', result.data);
  return result;
};

const PostsUser = async (endpoint, Authorization) => {
  const result = await axios.get(`${baseURL}${endpoint}`, { headers: { Authorization } });
  return result.data;
};

export {
  loginUser,
  PostsUser,
  PostsUserid,
};
