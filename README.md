**Disclaimer:** Este projeto � desenvolvido de forma independente e n�o possui qualquer rela��o com a SteelSeries. A biblioteca OpenSteelSeries.Sonar.SDK foi criada para fornecer uma interface de comunica��o com a API REST do SteelSeries Sonar, mas seu desenvolvimento � realizado de maneira n�o oficial e n�o est� associado � SteelSeries.

# OpenSteelSeries.Sonar.SDK

**OpenSteelSeries.Sonar.SDK** � uma biblioteca de c�digo aberto projetada para fornecer uma interface de comunica��o com a API REST do SteelSeries Sonar. Com ela, voc� pode:

- [x] Alterar o modo de opera��o entre cl�ssico e streamer.
- [x] Ajustar o volume de cada dispositivo.
- [x] Mutar e desmutar seu microfone.
- [x] Alterar o perfil de cada dispositivo.
- [x] Resgatar o estado de cada uma das funcionalidades acima.

**Nota:** O uso desta biblioteca pode ser afetado por atualiza��es no SteelSeries Sonar, e � importante estar ciente disso ao decidir implement�-la em seu projeto.

## RoadMap

**Feito:**
- [x] VolumeSettings Classic
- [x] VolumeSettings Streamer
- [x] Configs
- [x] Mode

**A fazer:**
- [ ] Redirecionamentos Classic
- [ ] Redirecionamentos Streamer
- [ ] Audio Devices
- [ ] Feature Controller
- E outras funcionalidades ainda n�o mapeadas

## Documenta��o

O projeto � separado em dois pacotes:

1. **OpenSteelSeries.Sonar.SDK**: Neste pacote, toda a interface de comunica��o est� implementada e pode ser utilizado individualmente. Para mais informa��es, leia o [README](OpenSteelSeries.Sonar.SDK/README.md).

2. **OpenSteelSeries.Sonar.SDK.DependencyInjection**: Este pacote tem como objetivo injetar as depend�ncias e facilitar seu uso. Para mais informa��es, leia o [README](OpenSteelSeries.Sonar.SDK.DependencyInjection/README.md).

Certifique-se de explorar a documenta��o de cada pacote para entender como utiliz�-los da melhor forma em seu projeto.
