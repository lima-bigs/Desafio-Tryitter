// eslint-disable-next-line import/no-extraneous-dependencies
import axios from 'axios';

const baseURL = process.env.REACT_APP_API_URL || 'http://localhost:3001';

const loginUser = async (endpoint, body) => {
  const { data } = await axios.post((baseURL + endpoint), body);
  return data;
};

const Post = async (endpoint, body, Authorization) => {
  const result = await axios.post((baseURL + endpoint), body, { headers: { Authorization } });
  return result;
};

const PostsUser = async (endpoint, Authorization) => {
  const result = await axios.get(`${baseURL}${endpoint}`, { headers: { Authorization } });
  return result.data;
};

export {
  loginUser,
  PostsUser,
  Post,
};
