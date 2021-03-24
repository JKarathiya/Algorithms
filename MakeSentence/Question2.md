```
Provider.findCity(51.5074, 0.1278)
  .then((x) => console.log(x))
  .catch((err) => console.log(err));

Provider.findCity(51.5074, 0.1278)
  .then((x) =>
    Provider.getWeather(x)
      .then((res) => console.log(res))
      .catch((weatherErr) => console.log(weatherErr))
  )
  .catch((cityError) => console.log(cityError));

const cityLondon = `London`;
Provider.getWeather(cityLondon)
  .then((res) => {
    console.log(res);
    Provider.getLocalCurrency(cityLondon)
      .then((res) => console.log(res))
      .catch((err) => console.log(err));
  })
  .catch((err) => console.log(err));
  ```