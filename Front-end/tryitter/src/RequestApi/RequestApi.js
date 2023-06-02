const URL = 'https://www....';

const RequestGetApi = async () => {
  const request = await fetch(URL);
  const result = await request.json();
  return result.results;
};

const RequestUnicoProduto = async (query) => {
  const request = await fetch(URL, query);
  const result = await request.json();
  return result;
};

export {
  RequestGetApi,
  RequestUnicoProduto,
};
